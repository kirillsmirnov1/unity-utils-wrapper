using UnityEngine;

using static UnityUtils.MonoBehaviourNullCheck;

namespace DefaultNamespace
{
    public class NullCheckTest : MonoBehaviour
    {
        [SerializeField] private Camera cam;
        public OtherScript otherScript;

        private void OnValidate() => this.CheckNullFields();
    }
}