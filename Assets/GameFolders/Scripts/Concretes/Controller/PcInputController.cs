using UnityEngine;

namespace GameFolders.Scripts.Controller
{
    public class PcInputController : MonoBehaviour
    {
        public bool LeftMouseClickDown => Input.GetMouseButtonDown(0);
        public bool RightMouseClickDown => Input.GetMouseButtonDown(1);
    }
}
