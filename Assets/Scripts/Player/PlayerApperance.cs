using Fusion;
using TMPro;
using UnityEngine;

public class PlayerApperance : NetworkBehaviour
{
    [SerializeField] private MeshRenderer MeshRenderer;
    [SerializeField] private WorldText playerName;

    [Networked, OnChangedRender(nameof(ColorChanged))]
    public Color NetworkedColor { get; set; }
    
    [Networked, OnChangedRender(nameof(ChangeName))]
    public string PlayerName { get; set; }

    public void SubmitName(string name)
    {
        PlayerName = name;
    }

    public void RandomColor()
    {
        NetworkedColor = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f), 1f);
    }
    void ColorChanged()
    {
        MeshRenderer.material.color = NetworkedColor;
    }

    void ChangeName()
    {
        playerName.ChangeName(PlayerName);
    }

    public override void Spawned()
    {
        if (HasStateAuthority)
        {
            GameController.Instance.PlayerSpawn(this);
        }
    }
}
