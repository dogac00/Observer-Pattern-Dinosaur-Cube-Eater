using UnityEngine;

public class Movable : MonoBehaviour
{
    float speed = 2;

    void Update()
    {
        Vector3 move =
            new Vector3(Input.GetAxis(nameof(MoveType.Horizontal)), 0, Input.GetAxis(nameof(MoveType.Vertical)));
        this.transform.position += move * speed * Time.deltaTime;
    }
}

enum MoveType
{
    Horizontal, Vertical
}