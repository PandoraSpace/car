using UnityEngine;

namespace Code.Providers
{
    public class CarProvider : MonoBehaviour
    {
        [SerializeField] private WheelCollider[] _frontWheels;
        [SerializeField] private WheelCollider[] _rearWheels;
        [SerializeField] private Transform[] _frontModelWheels;
        [SerializeField] private Transform[] _rearModelWheels;

        public WheelCollider[] FrontWheels => _frontWheels;
        public WheelCollider[] RearWheels => _rearWheels;
        public Transform[] FrontModelWheels => _frontModelWheels;
        public Transform[] RearModelWheels => _rearModelWheels;
    }
}