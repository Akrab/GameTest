using UnityEngine;

namespace PG.Game
{
    public class SmoothCameraFollow : CustomBehaviour
    {
        [SerializeField] private Vector3 offset;
        [SerializeField] private Transform target;
        [SerializeField] private float smooth;
        [SerializeField] private float Y_Border = - 100f;

        private Vector3 m_currentVelocity = Vector3.zero;
        private Vector3 m_targetPostion = Vector3.zero;

        public void SetTarget(Transform target )
        {
            this.target = target;
            offset = transform.position - target.position;
        }

        public override void CLateUpdate()
        {
            if (!target)
                return;
            m_targetPostion = target.position + offset;
            if (m_targetPostion.y <= Y_Border)
                m_targetPostion.y = Y_Border;
            transform.position = Vector3.SmoothDamp(transform.position, m_targetPostion, ref m_currentVelocity, smooth);
            
        }

    }
}