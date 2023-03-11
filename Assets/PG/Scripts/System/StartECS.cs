using Leopotam.EcsLite;
using PG.ECS.Game;
using PG.ECS.Game.Player;
using PG.ECS.UI;
using Zenject;

namespace PG.System
{
    public class StartECS : CustomBehaviour
    {
        [Inject] EcsWorld worldGame;

        EcsSystems gameUpdateSys;
        EcsSystems gameFixedUpdateSys;

        [Inject]
        public void Initialize()
        {
            gameUpdateSys = new EcsSystems(worldGame);

            gameFixedUpdateSys = new EcsSystems(worldGame);
#if UNITY_EDITOR
            gameUpdateSys.Add(new Leopotam.EcsLite.UnityEditor.EcsWorldDebugSystem());
            gameFixedUpdateSys.Add(new Leopotam.EcsLite.UnityEditor.EcsWorldDebugSystem());
#endif


            gameUpdateSys.Add(new EcsMovePlayer());
            gameUpdateSys.Add(new EcsPlayerRotation());
            gameUpdateSys.Add(new EcsPlayGame());
            
            gameFixedUpdateSys.Add(new EcsKillZ());


            gameUpdateSys.Init();
            gameFixedUpdateSys.Init();
        }

        public override void CUpdate()
        {
            // ��������� ��� ������������ �������.
            gameUpdateSys?.Run();
        }

        public override void CFixedUpdate()
        {            // ��������� ��� ������������ �������.
            gameFixedUpdateSys?.Run();
        }
        void OnDestroy()
        {
            // ���������� ������������ �������.
            if (gameUpdateSys != null)
            {
                gameUpdateSys.Destroy();
                gameUpdateSys = null;
            }
            // ���������� ������������ �������.
            if (gameFixedUpdateSys != null)
            {
                gameFixedUpdateSys.Destroy();
                gameFixedUpdateSys = null;
            }
            // ������� ���������.
            if (worldGame != null)
            {
                worldGame.Destroy();
                worldGame = null;
            }
        }
    }
}
