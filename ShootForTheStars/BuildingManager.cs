using Contracts;
using UnityEngine;

namespace ShootForTheStars
{
    [KSPAddon(KSPAddon.Startup.SpaceCentre, false)]
    public class BuildingManager : MonoBehaviour
    {
        private void Start()
        {
            gameObject.AddComponent<ContractSystem>();
        }
    }
}