using UnityEngine;

public class MenuUI : MonoBehaviour
{
    [SerializeField] GameObject panel;
    [SerializeField] GameObject bg;
    private GameObject chart;
    public void ActivatePanel(GameObject chart) {
        panel.SetActive(true);
        bg.SetActive(true);
        chart.SetActive(true);
        this.chart = chart;
    }
    public void DeactivatePanel() {
        panel.SetActive(false);
        bg.SetActive(false);
        chart.SetActive(false);
    }
}
