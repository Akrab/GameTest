using PG.ECS.Game.Player;
using UnityEngine;
using static UnityEngine.EventSystems.EventTrigger;

namespace PG.Game.Player
{
    public class MoveCtr : PlayerBaseMoveCtrl
    {
        [SerializeField] float speed;
        
        protected override void setup()
        {
            controller = GetComponent<Rigidbody>();
        }

        public override void CFixedUpdate()
        {
            controller.MovePosition(transform.position + IsoVectorConvert(direction) * Time.deltaTime * speed);
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