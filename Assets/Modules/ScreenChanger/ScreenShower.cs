using UnityEngine;

namespace Modules.ScreenChanger
{
    public class ScreenShower : MonoBehaviour
    {

        [SerializeField] private ScreenBehaviour selectedScreen;

        public void Change(ScreenBehaviour nextScreen)
        {
            if (selectedScreen != null)
            {
                selectedScreen.Hide();
            }
            selectedScreen = nextScreen;
            if (selectedScreen != null)
            {
                selectedScreen.Show();
            }
        }
    }
}
