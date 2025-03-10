using TMPro;
using UnityEngine;
using Utilities;

public class GameController : ManualSingletonMono<GameController>
{
    [SerializeField] private GameObject mainCanvas;
    [SerializeField] private TMP_InputField inputName;
    
    private PlayerApperance currentPlayerApperance;

    public void PlayerSpawn(PlayerApperance apperance)
    {
        mainCanvas.SetActive(true);
        currentPlayerApperance = apperance;
        string randomName = $"Player {UnityEngine.Random.Range(0, 100)}";
        inputName.text = randomName;
        Submit();
    }
    public void Submit()
    {
        currentPlayerApperance.SubmitName(inputName.text);
    }

    public void RandomColor()
    {
        currentPlayerApperance.RandomColor();
    }
}
