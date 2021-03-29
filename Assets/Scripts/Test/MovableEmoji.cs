using Joysticks;
using UnityEngine;

namespace Test
{
    public class MovableEmoji : MonoBehaviour
    {
        [SerializeField] private ImplicitJoystick implicitJoystick;
        [SerializeField] private Joystick joystick;
        [SerializeField] private float speed = 1f;


        private RectTransform _rectTransform;
        private float _radius;

        private void Awake()
        {
            _rectTransform = GetComponent<RectTransform>();
            _radius = _rectTransform.sizeDelta.x / 2;
        }

        // Update is called once per frame
        private void Update()
        {
            var dir = implicitJoystick.Direction + joystick.Direction;

            var newPos = (Vector2) _rectTransform.position + dir * speed;

            _rectTransform.position = new Vector2(
                Mathf.Clamp(newPos.x, _radius, Screen.width - _radius),
                Mathf.Clamp(newPos.y, _radius, Screen.height - _radius));
        }
    }
}