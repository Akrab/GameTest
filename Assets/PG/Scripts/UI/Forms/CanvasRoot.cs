using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace PG.UI
{
    public class CanvasRoot : MonoBehaviour
    {
        [SerializeField]
        public RectTransform rect;
        public List<IForm> SetupUI()
        {
            var forms = GetComponentsInChildren<IForm>();

            foreach (var form in forms)
            {
                form.InitUIRoot(rect);
                form.Disable();
            }

            return new List<IForm>(forms);
        }
    }
}
