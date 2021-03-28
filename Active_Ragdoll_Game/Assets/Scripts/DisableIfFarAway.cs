using UnityEngine;

public class DisableIfFarAway : MonoBehaviour
{
    private GameObject m_itemActivatorObj = null;

    private ItemActivator m_activatonScript = null;


    private void Awake()

    {
        m_itemActivatorObj = GameObject.Find("ItemActivatorObject");
        m_activatonScript = m_itemActivatorObj.GetComponent<ItemActivator>();
    }

    private void Start()
    {
        // Use a public method to add to the list, rather than making it public:
        m_activatonScript.Register(new ActivatorItem(this.gameObject, this.transform.position));
    }
}
