using System.Collections;
using UnityEngine;

public class JumpPadParticleControl : MonoBehaviour
{
    public ParticleSystem hitParticle;
    public bool moduleEnabled = false;

    private void Start()
    {
        var emission = hitParticle.emission;

        emission.enabled = moduleEnabled;

    }

    public void onCollionEnter(Collision collision)
    {
        var emission = hitParticle.emission;

        emission.enabled = true;
        StartCoroutine("test");
        Debug.Log(collision.gameObject);
    }

    private IEnumerable test()
    {

        var emission = hitParticle.emission;
        emission.enabled = false;

        yield return new WaitForSeconds(.1f);
    }

}
