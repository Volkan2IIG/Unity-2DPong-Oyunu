using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Ball : MonoBehaviour
{
    public float speed = 200f; // topun hızı
    public new Rigidbody2D rigidbody { get; private set; }
    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }
    //başlangıç pozisyonu 0
    public void ResetPosition()
    {
        rigidbody.velocity = Vector2.zero;
        rigidbody.position = Vector2.zero;
    }

    public void AddStartingForce()
    {
        float x = Random.value < 0.5f ? -1f : 1f; // sağ-sol için random 
        float y = Random.value < 0.5f ? Random.Range(-1f, -0.5f) // yukarı-aşağı için random 
                                      : Random.Range(0.5f, 1f); // çapraz haraket için
        Vector2 direction = new Vector2(x, y);
        rigidbody.AddForce(direction * speed);
    }

}








