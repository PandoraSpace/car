using UnityEngine;

namespace Code.Configs
{
    [CreateAssetMenu]
    public class CarConfig : ScriptableObject
    {
        [SerializeField] private float _enginePower;
        [SerializeField] private float _brakingForce;
        [SerializeField] private float _steerAngle;

        public float EnginePower => _enginePower;
        public float BrakingForce => _brakingForce;
        public float SteerAngle => _steerAngle;
    }
}