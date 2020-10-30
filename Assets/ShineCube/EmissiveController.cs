using UnityEngine;

public class EmissiveController : MonoBehaviour
{
    private Material mat;
    private float fact;

    private float defIntensity = 0;
    private float variation = 0.05f;

    // 発光で白画面化 ====================
    /*
    void Start()
    {
        mat = GetComponent<MeshRenderer>().material;
    }
    void Update()
    {
        fact = Mathf.Pow( 2, defIntensity += variation );
        mat.SetColor( "_EmissionColor", new Color( mat.color.r * fact, mat.color.g * fact, mat.color.b * fact ) );
    }
    */
    // ========================================

    // 明滅 ========================================
    private float time;

    const float seconds = 1.5f;

    void Start()
    {
        mat = GetComponent<MeshRenderer>().material;
    }
    void Update()
    {
        time += Time.deltaTime;
        fact = Mathf.Pow( 2, defIntensity += variation );

        if( time < seconds )
        {
            mat.SetColor( "_EmissionColor", new Color( mat.color.r * fact, mat.color.g * fact, mat.color.b * fact ) );
        }
        else
        {
            time = 0f;
            variation = -variation;
        }
    }

    // ========================================
}
