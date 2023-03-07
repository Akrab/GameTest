using Leopotam.EcsLite;
using PG.ECS.UI;
using UnityEngine;
using Zenject;

namespace PG.UI
{

    public interface IForm
    {
        void InitUIRoot(RectTransform rect);
        void Disable();
        bool isShow { get; }

    }

    public class BaseForm : CustomBehaviour, IForm
    {

        public bool isShow => gameObject.activeSelf;

        protected Canvas canvas;
        [Inject] private EcsWorld _ecsWorld;
        private int ecsIndex;
        public void Disable()
        {
            gameObject.SetActive(false);
        }

        [Inject]
        public void Initialize()
        {
            ecsIndex = _ecsWorld.NewEntity();
            var pool = _ecsWorld.GetPool<EFormComp>();
            ref EFormComp c1 = ref pool.Add(ecsIndex);
            c1.form = this;
        }

        public void InitUIRoot(RectTransform rectData)
        {
            canvas = GetComponentInChildren<Canvas>();
            var _rect = canvas.GetComponent<RectTransform>();
            _rect.sizeDelta = rectData.sizeDelta;
            gameObject.transform.localPosition = Vector3.zero;

        }
    }
}