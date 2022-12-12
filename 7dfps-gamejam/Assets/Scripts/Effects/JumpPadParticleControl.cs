using System.Collections;
using UnityEngine;

public class JumpPadParticleControl : MonoBehaviour
{
    public ParticleSystem engineParticle;
    public GameObject engineGO;
    public bool engineEnable = false;

    private void Start()
    {
        //engine particle system on/off
        var emission = engineParticle.emission;
        emission.enabled = engineEnable;

        //engine mesh on/off
        engineGO.GetComponent<MeshRenderer>().enabled = engineEnable;
    }

    

}
