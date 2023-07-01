using Code.Core;
using UnityEngine;

namespace Code.Providers
{
    public class UIProvider : MonoBehaviour
    {
        [SerializeField] private CustomButton _up;
        [SerializeField] private CustomButton _down;
        [SerializeField] private CustomButton _left;
        [SerializeField] private CustomButton _right;
        [SerializeField] private CustomButton _break;

        public CustomButton Up => _up;
        public CustomButton Down => _down;
        public CustomButton Left => _left;
        public CustomButton Right => _right;
        public CustomButton Break => _break;
    }
}