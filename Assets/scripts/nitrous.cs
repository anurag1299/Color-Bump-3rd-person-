
using UnityEngine;
using UnityEngine.UI;
public class nitrous : MonoBehaviour
{
    public playerMovement pm;
    public Text nitro;

    // Update is called once per frame
    void Update()
    {
        nitro.text = "Nitrous:" + pm.nitrous.ToString();
    }
}
