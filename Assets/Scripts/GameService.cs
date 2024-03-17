using System.Collections;
using System.Collections.Generic;
using ServiceLocator.Map;
using ServiceLocator.Player;
using ServiceLocator.Sound;
using ServiceLocator.UI;
using ServiceLocator.Utilities;
using ServiceLocator.Wave;
using UnityEngine;

public class GameService : GenericMonoSingleton<GameService>
{

    //Responsiblities 
    //1. Maintain and give access of services across the board
    //2. Create Respected Service
    public PlayerService playerService {get ; private set;}
    public SoundService soundService { get; private set;}
    public WaveService waveService { get; private set;}

    public MapService mapService { get; private set;}
    [SerializeField] private UIService uIService;
    public UIService UIService => uIService;
    [SerializeField] private PlayerScriptableObject playerScriptableObject;
    [Header("Sound Service")]
    [SerializeField] private SoundScriptableObject soundScriptableObject;

    [SerializeField] private AudioSource audioEffects , backgroundMusic;

    [Header("Wave Servcie")]
    [SerializeField] private WaveScriptableObject waveScriptableObject;

    [Header("Map Service")]
    [SerializeField] private MapScriptableObject mapScriptableObject;
    

    private void Start() {
        playerService = new PlayerService(playerScriptableObject);
        soundService = new SoundService(soundScriptableObject,audioEffects , backgroundMusic);
        waveService = new WaveService(waveScriptableObject);
        mapService = new MapService(mapScriptableObject);
    }
    private void Update() {
        playerService.Update();
    }
}
