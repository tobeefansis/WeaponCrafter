using System;
using UnityEngine;
using UnityEngine.Events;
using Zenject;

namespace Modules.ScreenChanger
{
   
    public class ScreenBehaviour : MonoBehaviour
    {
        [Inject] [SerializeField] private ScreenShower screenShower;
        [SerializeField] internal bool showInStart;
        [SerializeField] private bool disableGOinHide;
        [SerializeField] private UnityEvent onShow;
        [SerializeField] private UnityEvent onHide;

      
        public void SelectAndShow()
        {
            screenShower.Change(this);
        }

        public void Show()
        {
            print($"{name} Show");
            if (disableGOinHide)
            {
                gameObject.SetActive(true);
            }
            onShow.Invoke();
        } 
        public void Hide()
        {
            print($"{name} Hide");
            if (disableGOinHide)
            {
                gameObject.SetActive(false);
            }
            onHide.Invoke();
        }
    }
}
