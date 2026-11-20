using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;
public class playerController : MonoBehaviour
{
    private float elapsedTime = 0f;
    private float score = 0f;
    public float scoreMultiplier = 10f;
    public float thrustForce = 1f;
    Rigidbody2D rb;
    public UIDocument uiDocument;
    private Label scoreText;
    private Button restartbutton;
    public GameObject explosionEffect;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        scoreText = uiDocument.rootVisualElement.Q<Label>("scoreLabel");
        restartbutton = uiDocument.rootVisualElement.Q<Button>("restartbutton");
        restartbutton.style.display = DisplayStyle.None;
        restartbutton.clicked += ReloadScene;
    }

    /*private T GetComponet<T>()
    {
        throw new NotImplementedException();
    }*/

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;
        score = Mathf.FloorToInt(elapsedTime * scoreMultiplier);
        Debug.Log("score: " + score);
        scoreText.text = "score: " + score;

        if (Mouse.current.leftButton.isPressed)
        {
            Vector3 mousepos = Camera.main.ScreenToWorldPoint(Mouse.current.position.value);
            Debug.Log("Mouse position:" + mousepos);

            Vector2 direction = (mousepos - transform.position).normalized;
            transform.up = direction;
            rb.AddForce(direction * thrustForce);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
        Instantiate(explosionEffect, transform.position, transform.rotation);
        restartbutton.style.display = DisplayStyle.Flex;
    }

    void ReloadScene() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }



}
