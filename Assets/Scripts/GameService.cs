using System.Collections;
using System.Collections.Generic;
using ServiceLocator.Player;
using ServiceLocator.Utilities;
using UnityEngine;

public class GameService : GenericMonoSingleton<GameService>
{

    //Responsiblities 
    //1. Maintain and give access of services across the board
    //2. Create Respected Service
    public PlayerService playerService {get ; private set;}
    [SerializeField] public PlayerScriptableObject playerScriptableObject;

    private void Start() {
        playerService = new PlayerService(playerScriptableObject);
    }
    private void Update() {
        playerService.Update();
    }
}
