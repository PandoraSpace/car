using Code.Configs;
using Code.Providers;
using UnityEngine;
using VContainer.Unity;

namespace Code.Services
{
    public class MoveService : IFixedTickable, ITickable
    {
        private readonly CarProvider _car;
        private readonly InputService _inputService;
        private readonly CarConfig _carConfig;

        public MoveService(CarProvider car, InputService inputService, CarConfig carConfig)
        {
            _car = car;
            _inputService = inputService;
            _carConfig = carConfig;
        }

        public void FixedTick()
        {
            foreach (WheelCollider frontWheel in _car.FrontWheels)
            {
                frontWheel.brakeTorque = _carConfig.BrakingForce * _inputService.Break;
                frontWheel.steerAngle = _carConfig.SteerAngle * _inputService.Steering;
            }

            foreach (WheelCollider rearWheel in _car.RearWheels)
            {
                rearWheel.brakeTorque = _carConfig.BrakingForce * _inputService.Break;
                rearWheel.motorTorque = _carConfig.EnginePower * _inputService.Acceleration;
            }
        }


        public void Tick()
        {
            for (var i = 0; i < _car.FrontWheels.Length; i++)
            {
                UpdateWheelModel(_car.FrontWheels[i], _car.FrontModelWheels[i]);
                UpdateWheelModel(_car.RearWheels[i], _car.RearModelWheels[i]);
            }
        }

        private void UpdateWheelModel(WheelCollider collider, Transform transform)
        {
            collider.GetWorldPose(out Vector3 position, out Quaternion rotation);

            transform.position = position;
            transform.rotation = rotation;
        }
    }
}