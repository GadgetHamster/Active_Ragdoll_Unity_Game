using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemActivator : MonoBehaviour
{
    [SerializeField] private float m_distanceFromPlayer = 10f;

    private GameObject m_player;
    private List<ActivatorItem> m_activatorItem;
    private IEnumerator m_coroutine = null;

    // Grab references in Awake() rather than Start():
    private void Awake()
    {
        m_player = GameObject.FindWithTag("pelvis");
        m_activatorItem = new List<ActivatorItem>();
    }

    private void Update()
    {
        if(m_coroutine != null) return;

        m_coroutine = CheckActivation();
        StartCoroutine(m_coroutine);
    }

    public void Register(ActivatorItem item)
    {
        m_activatorItem.Add(item);
    }

    public void DeRegister(ActivatorItem item)
    {
        m_activatorItem.Remove(item);
    }

 private IEnumerator CheckActivation()
        {
          List<ActivatorItem> removeList = new List<ActivatorItem>();

          if(m_activatorItem.Count > 0f)
          {
            foreach(ActivatorItem item in m_activatorItem)
            {
                if (item.m_item == null)
                {
                    removeList.Add(item);
                    continue;
                }

                bool isActive = Vector3.Distance(m_player.transform.position, item.m_itemPos) < m_distanceFromPlayer;

                item.m_item.SetActive(isActive);

               // Alternative one liner, but might be harder to read:
               //item.m_item.SetActive(Vector3.Distance(m_player.transform.position, item.m_itemPos) < m_distanceFromPlayer);

            }
        }

        yield return new WaitForSeconds(0.01f);

        if (removeList.Count > 0f)
        {
            foreach(ActivatorItem item in removeList)
            {
                m_activatorItem.Remove(item);
            }
        }

        yield return new WaitForSeconds(0.01f);

        m_coroutine = null;
    }
}
public class ActivatorItem
{
  public GameObject m_item;
  public Vector3 m_itemPos;
  public ActivatorItem(GameObject i, Vector3 i_pos) {
   m_item = i;
   m_itemPos = i_pos;  
  }
}
