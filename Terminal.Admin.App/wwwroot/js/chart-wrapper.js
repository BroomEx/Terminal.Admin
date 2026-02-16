window.chartWrapper = {
    charts: {},

    init: function (canvasId, labels, data) {
        var ctx = document.getElementById(canvasId).getContext('2d');

        // Destroy existing chart if any
        if (this.charts[canvasId]) {
            this.charts[canvasId].destroy();
        }

        var config = {
            type: 'line',
            data: {
                labels: labels,
                datasets: [{
                    label: 'Power (MW)',
                    data: data,
                    backgroundColor: 'rgba(0, 124, 165, 0.2)', // deep cerulean transparent
                    borderColor: '#007CA5', // deep cerulean
                    borderWidth: 2,
                    pointRadius: 0,
                    tension: 0.4,
                    fill: true
                }]
            },
            options: {
                responsive: true,
                maintainAspectRatio: false,
                animation: false, // Disable initial animation for immediate display
                interaction: {
                    mode: 'index',
                    intersect: false,
                },
                scales: {
                    x: {
                        display: true,
                        title: {
                            display: true,
                            text: 'Time'
                        }
                    },
                    y: {
                        display: true,
                        title: {
                            display: true,
                            text: 'Power [MW]'
                        },
                        suggestedMin: 0,
                        suggestedMax: 100
                    }
                }
            }
        };

        this.charts[canvasId] = new Chart(ctx, config);
    },

    update: function (canvasId, label, value) {
        var chart = this.charts[canvasId];
        if (chart) {
            // Add new data
            chart.data.labels.push(label);
            chart.data.datasets.forEach((dataset) => {
                dataset.data.push(value);
            });

            // Remove old data if more than limit (e.g., 20)
            if (chart.data.labels.length > 20) {
                chart.data.labels.shift();
                chart.data.datasets.forEach((dataset) => {
                    dataset.data.shift();
                });
            }

            // Update chart without animation for "smooth" feel or minimal 'none' mode
            chart.update('none');
        }
    },

    dispose: function (canvasId) {
        if (this.charts[canvasId]) {
            this.charts[canvasId].destroy();
            delete this.charts[canvasId];
        }
    }
};
