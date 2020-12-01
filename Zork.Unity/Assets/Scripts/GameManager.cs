using UnityEngine;
using Zork;
using TMPro;

public class GameManager : MonoBehaviour
{
    public string ZorkFilename = @"Assets\Resources\Zork.json";
    public TMP_Text LocationText;
    public TMP_Text ScoreText;
    public TMP_Text MoveText;
    public UnityOutputService OutputService;
    public UnityInputService InputService;
    
    [SerializeField]
    private string ZorkGameFileAssetName = "Zork";

    void Awake()
    {
        TextAsset gameJsonAsset = Resources.Load<TextAsset>(ZorkGameFileAssetName);

        Game.Start(gameJsonAsset.text, InputService, OutputService);

        Game.Instance.CommandManager.PerformCommand(Game.Instance, "LOOK");
    }

    private void Update()
    {
        LocationText.text = Game.Instance.Player.Location.ToString();
        MoveText.text = "Moves: " + Game.Instance.Player.Moves.ToString();
    }
}
