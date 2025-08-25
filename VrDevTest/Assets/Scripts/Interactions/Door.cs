using UnityEngine;

namespace Interactables
{
    public class Door : MonoBehaviour
    {
        [SerializeField] Animator animator;
        bool isOpen = false;
        int openDoorHashCode;

        private void Start()
        {
            openDoorHashCode = Animator.StringToHash("Open");
        }

        public void OnToggle()
        {
            Debug.Log("OnToggle");
            isOpen = !isOpen;
            animator.SetBool(openDoorHashCode, isOpen);
        }

    }
}
