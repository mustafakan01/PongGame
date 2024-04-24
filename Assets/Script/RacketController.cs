using UnityEngine;

public class RacketController : MonoBehaviour
{
    public float speed;
    public float limitHorizontal = 2.2f;
    public bool isUp;
    [SerializeField] private bool isPlayer;

    [SerializeField] private float aiSpeed;

    // Update is called once per frame
    private void Update()
    {
        Vector3 newPosition = transform.position;

        if (isPlayer)
        {
            // Mobil cihazlarda dokunmatik giriþi kullan
            if (Input.touchCount > 0)
            {
                Touch touch = Input.GetTouch(0);
                float touchPositionX = Camera.main.ScreenToWorldPoint(touch.position).x;
                newPosition.x = Mathf.Clamp(touchPositionX, -limitHorizontal, limitHorizontal);
            }
        }
        else
        {
            // AI'nýn topun pozisyonunu takip etme hýzýný ayarla
            float aiTargetX = Mathf.Lerp(newPosition.x, Ball.Instance.transform.position.x, aiSpeed * Time.deltaTime);
            newPosition.x = aiTargetX;
        }

        // Yeni pozisyonu güncelle
        transform.position = newPosition;
    }
}
