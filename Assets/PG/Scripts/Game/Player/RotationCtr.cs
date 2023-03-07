using PG.ECS.Game.Player;
using UnityEngine;

namespace PG.Game.Player
{
    public class RotationCtr : PlayerBaseMoveCtrl
    {
        [SerializeField] float rotationSpeed = 3f;
        float _currentVelocity;
        public override void CUpdate()
        {
            if (direction == Vector3.zero)
                return;
            var targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;
            targetAngle -= 45;
            targetAngle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, 
                ref _currentVelocity, rotationSpeed * Time.deltaTime);
            transform.rotation = Quaternion.Euler(0f, targetAngle, 0);

        }

        public override void SetComps()
        {
            ecsIndex = _ecsWorld.NewEntity();

            var pool = _ecsWorld.GetPool<EMoveComp>();
            ref EMoveComp c1 = ref pool.Add(ecsIndex);
            c1.listener = this;
        
        
        }
    }
}