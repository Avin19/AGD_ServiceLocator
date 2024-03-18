using UnityEngine;
using UnityEngine.UI;
using ServiceLocator.Main;
using ServiceLocator.Events;

namespace ServiceLocator.UI
{
    public class MapButton : MonoBehaviour
    {
        [SerializeField] private int MapId;
        public EventService eventService;

        private void Start() => GetComponent<Button>().onClick.AddListener(OnMapButtonClicked);

        // To Learn more about Events and Observer Pattern, check out the course list here: https://outscal.com/courses
        private void OnMapButtonClicked() => GameService.Instance.EventService.OnMapSelected.InvokeEvent(MapId);
    }
}