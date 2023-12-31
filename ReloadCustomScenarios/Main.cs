using UnityEngine;

namespace ReloadCustomScenarios
{
    public class Main : VTOLMOD
    {
        public override void ModLoaded()
        {
            VTOLAPI.SceneLoaded += SceneLoaded;
            base.ModLoaded();
        }

        private void SceneLoaded(VTOLScenes scene)
        {
            switch (scene)
            {
                case VTOLScenes.VTEditMenu:
                    Debug.Log("[ReloadCustomScenariosMod] Scene \"VTEditMenu\" loaded! Reloading scenarios!");
                    VTResources.LoadCustomScenarios(false);
                    break;
            }
        }
    }
}