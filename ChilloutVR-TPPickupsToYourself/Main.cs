using MelonLoader;
using UnityEngine;
using ABI.CCK.Components;

namespace ChilloutVR_TPPickupsToYourself
{
    public class Main : MelonMod
    {
        public override void OnUpdate()
        {
            if (Input.GetKey(KeyCode.Y))
            {
                var Pickups = Resources.FindObjectsOfTypeAll<CVRPickupObject>();
                foreach (var item in Pickups)
                {
                    item.GetComponent<CVRPickupObject>().grabbedBy = GameObject.Find("_PLAYERLOCAL/Voice Centralizer").GetComponent<Dissonance.Integrations.DarkRift2.DarkRift2Player>().PlayerId;
                    item.transform.position = GameObject.Find("_PLAYERLOCAL").transform.position;
                }
            }
        }
    }
}
