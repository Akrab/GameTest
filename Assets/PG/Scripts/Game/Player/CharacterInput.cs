using Leopotam.EcsLite;
using PG.ECS.Game.Player;
using UnityEngine;
using UnityEngine.InputSystem;
using Zenject;

namespace PG.Game
{

    public interface IInputListener
    {
        void SetInput(Vector3 data);
    }

    public class CharacterInput : MonoBehaviour
    {
        Vector3 data = Vector3.zero;

        [Inject] EcsWorld ecsWorld;

        [Inject]
        public void Initialize()
        {
            var m_pl = GetComponent<PlayerInput>().actions;
            var map = m_pl.FindActionMap("GamePlay");
            var wasd = map.FindAction("Move");
            wasd.performed += InputMove;
            wasd.canceled += InputMove;

            UpdateData();
        }

        private void InputMove(InputAction.CallbackContext obj)
        {
            var v = obj.ReadValue<Vector2>();

            data.x = v.x;
            data.y = 0;
            data.z = v.y;
            UpdateData();
        }

        private void UpdateData()
        {

            var entity = ecsWorld.NewEntity();

            var pool = ecsWorld.GetPool<EInputComp>();
            ref EInputComp c1 = ref pool.Add(entity);
            c1.data = data;
        }

    }
}
