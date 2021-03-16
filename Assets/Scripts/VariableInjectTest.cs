using TMPro;
using UnityEngine;
using UnityUtils.Variables;

namespace DefaultNamespace
{
    public class VariableInjectTest : MonoBehaviour
    {
        [SerializeField] private CanvasVariable canvasVariable;
        [SerializeField] private GameObjectVariable gameObjectVariable;
        
        private void Awake()
        {
            TryToCreateAnObjectOnInjectedCanvas();
            TryToRenameInjectedGameObject();
        }

        private void TryToRenameInjectedGameObject() => gameObjectVariable.Value.name = "✨RENAMED INJECTED GAME OBJECT";

        private void TryToCreateAnObjectOnInjectedCanvas()
        {
            var createdObject = new GameObject();
            createdObject.transform.parent = canvasVariable.Value.transform;
            createdObject.AddComponent<RectTransform>().anchoredPosition = Vector2.zero;
            var textOnObject = createdObject.AddComponent<TextMeshProUGUI>();
            textOnObject.text = "DI FTW";
            textOnObject.color = Color.red;
        }
    }
}