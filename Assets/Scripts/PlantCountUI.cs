using UnityEngine;
using TMPro;

public class PlantCountUI : MonoBehaviour
{
    [SerializeField] private TMP_Text _plantedText;
    [SerializeField] private TMP_Text _remainingText;

    public void UpdateSeeds (int seedsLeft, int seedsPlanted)
    {
        _plantedText.text = "Seeds Planted: " + seedsPlanted; //displays # of seeds planted by the player
        _remainingText.text = "Seeds Left: " + seedsLeft; //displays # of seeds avaible left for the player
    }
}