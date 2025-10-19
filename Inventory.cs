using UnityEngine;


public class Inventory : MonoBehaviour
{
    public int coins = 0;

    private void OnCollisionEnter2D (Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {
            Destroy(collision.gameObject);
            coins++;
            print("Монеты: " + coins);
        }

        if (collision.gameObject.CompareTag("Trap"))
            Destroy(collision.gameObject);
    }
}
