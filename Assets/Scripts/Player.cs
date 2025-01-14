using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 1.0f;
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private GameObject _plantPrefab;
    [SerializeField] private int _numSeeds = 5; 
    [SerializeField] private PlantCountUI _plantCountUI;

    private int _numSeedsLeft;
    private int _numSeedsPlanted;

    private void Start ()
    {
        _numSeedsLeft = _numSeeds; //sets the number of seeds left equal to the available seeds at the game's start
        _numSeedsPlanted = 0; //sets number of seeds planted to 0 at the game's start
        _plantCountUI.UpdateSeeds(_numSeedsLeft,_numSeedsPlanted); //shows UI at the game's start
    }

    private void Update()
    {
        if(Input.GetKey(KeyCode.W)) //gets key pressed on keyboard and corresponds it to the sprite's movement on the screen
        {
        _playerTransform.Translate(Vector3.up * _speed * Time.deltaTime);   
        }
        if(Input.GetKey(KeyCode.S))
        {
        _playerTransform.Translate(Vector3.down * _speed * Time.deltaTime);    
        }
         if(Input.GetKey(KeyCode.A))
        {
        _playerTransform.Translate(Vector3.left * _speed * Time.deltaTime);    
        }
        if(Input.GetKey(KeyCode.D))
        {
        _playerTransform.Translate(Vector3.right * _speed * Time.deltaTime);    
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(_numSeedsLeft > 0) // allows the player to plant a seed as long as they have seeds left
            {
                PlantSeed(); //calls plant seed
            } 
        }
    }

    public void PlantSeed ()
    {
        GameObject plant = Instantiate(_plantPrefab,transform.position,transform.rotation); //spawns a prefab at the player's position
        _numSeedsLeft--; // subtracts one from seeds remaining and adds one to seeds planted
        _numSeedsPlanted++;
        _plantCountUI.UpdateSeeds(_numSeedsLeft,_numSeedsPlanted); // calls updateseeds to update the game ui according to how many seeds are planted
        
    }
    
    
        
        
    
}
