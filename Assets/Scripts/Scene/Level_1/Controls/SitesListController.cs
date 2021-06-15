using Assets.Scripts.Scene.Level_1.Models;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Scene.Level_1.Controls
{
    public class SitesListController : MonoBehaviour
    {
        public Text SitesListText;

        void Start()
        {
            SitesListText.text = "Список корректных ссылок:";
            foreach(var site in LinkPresets.Presets)
                SitesListText.text += $"\n{site.Correct}";
        }
    }
}
