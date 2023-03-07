using Leopotam.EcsLite;
using UnityEngine;

namespace PG.Game.Player
{
    public abstract class PlayerBaseMoveCtrl : CustomBehaviour, IInputListener, IEntity
    {
        protected Rigidbody controller;
        protected Vector3 direction = Vector3.zero;
        protected EcsWorld _ecsWorld;
        protected int ecsIndex = -1;
        protected override void setup()
        {
            controller = GetComponent<Rigidbody>();
        }

        public void SetInput(Vector3 direct)
        {
            direction = direct;
        }

        protected Vector3 IsoVectorConvert(Vector3 input)
        {

            Quaternion rotation = Quaternion.Euler(0, 45, 0);
            Matrix4x4 isoMatrix = Matrix4x4.Rotate(rotation);
            return isoMatrix.MultiplyPoint3x4(input);
        }

        public void SetWorld(EcsWorld ecsWorld)
        {
            _ecsWorld = ecsWorld;
            SetComps();
        }

        public abstract void SetComps();
    }
}
