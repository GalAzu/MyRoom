using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Vector3 newPosition;
    public int coins { get; private set; }
    [SerializeField]private float speed;
    public static PlayerController instance;
    private void Start()
    {
        instance = this;
        newPosition = transform.position;
        coins = 5;
    }

    private void Update()
    {
        GetNewPosition();
        transform.position = Vector3.MoveTowards(transform.position, newPosition, speed * Time.deltaTime);
    }
    private void GetNewPosition()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                newPosition.x = hit.point.x;
                newPosition.z = hit.point.z;
            }
        }
    }
    public void ReduceCoinsOnPlay() => coins--;
    public void GainCoinsOnWin() => coins++;

}
