const btnLoadPatients = document.getElementById("btnLoadPatients");
const patientsContainer = document.getElementById("patientsContainer");

const btnLoadLabResults = document.getElementById("btnLoadLabResults");
const labResultsContainer = document.getElementById("labResultsContainer");

btnLoadPatients.addEventListener("click", async () => {
    try {
        patientsContainer.innerHTML = "<p class='loading'>Cargando pacientes...</p>";

        const response = await fetch("/api/patients");
        if (!response.ok) {
            throw new Error("Error al obtener pacientes");
        }
        const data = await response.json();
        renderPatients(data);
    } catch (error) {
        console.error(error);
        patientsContainer.textContent = "No se pudieron cargar los pacientes.";
    }
});

btnLoadLabResults.addEventListener("click", async () => {
    try {
        labResultsContainer.innerHTML = "<p class='loading'>Cargando resultados...</p>";

        const response = await fetch("/api/patients/ccl");
        if (!response.ok) {
            throw new Error("Error al obtener resultados de laboratorio");
        }
        const data = await response.json();
        renderLabResults(data);
    } catch (error) {
        console.error(error);
        labResultsContainer.textContent = "No se pudieron cargar los resultados.";
    }
});

function renderPatients(patients) {
    patientsContainer.innerHTML = "";
    if (!patients || patients.length === 0) {
        patientsContainer.textContent = "No hay pacientes disponibles.";
        return;
    }

    const ul = document.createElement("ul");
    patients.forEach((p) => {
        const li = document.createElement("li");
        li.textContent = `ID: ${p.id} - Nombre: ${p.fullName}`;
        ul.appendChild(li);
    });
    patientsContainer.appendChild(ul);
}

function renderLabResults(results) {
    labResultsContainer.innerHTML = "";
    if (!results || results.length === 0) {
        labResultsContainer.textContent = "No hay resultados de laboratorio.";
        return;
    }

    const ul = document.createElement("ul");
    results.forEach((r) => {
        const li = document.createElement("li");
        li.textContent = `Valor: ${r.resultValue}, Fecha: ${r.dateTime}`;
        ul.appendChild(li);
    });
    labResultsContainer.appendChild(ul);
}

// === Toggle Tema con switch profesional ===
const html = document.documentElement;
const themeSwitcher = document.getElementById("themeSwitcher");

document.addEventListener("DOMContentLoaded", () => {
    const savedTheme = localStorage.getItem("theme") || "light";
    html.setAttribute("data-theme", savedTheme);
});

themeSwitcher.addEventListener("click", () => {
    const current = html.getAttribute("data-theme");
    const next = current === "dark" ? "light" : "dark";
    html.setAttribute("data-theme", next);
    localStorage.setItem("theme", next);
});
