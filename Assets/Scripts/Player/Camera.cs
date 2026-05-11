using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameObject Player;
    private void Update()
    {
        transform.position = new Vector3(Player.transform.position.x, Player.transform.position.y, -10);
    }
}
