using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
    private NavMeshAgent agent;

    void Start()
    {
        // Obtenemos la referencia al NavMeshAgent del Player
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        // Si hacemos clic izquierdo en la pantalla
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                // Le decimos al agente que camine hacia el punto donde hicimos clic
                agent.SetDestination(hit.point);
            }
        }
    }
}