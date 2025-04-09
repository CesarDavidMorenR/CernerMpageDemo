# 🩺 MPage Demo – Proyecto Técnico Full Stack para entorno Cerner Millennium

Este proyecto demuestra mi capacidad para aprender rápido y aplicar buenas prácticas de desarrollo en un entorno sanitario, orientado al mantenimiento y evolución de **MPages** en **Cerner Millennium**. Se trata de una simulación funcional de una MPage que:

- 🔗 Consume datos reales de un servidor **FHIR** (https://hapi.fhir.org/)
- 🧠 Simula consultas SQL/CCL
- 🌐 Se presenta en una interfaz clara, moderna y accesible
- 🔧 Utiliza tecnologías clave del entorno Cerner y desarrollo full stack

---

## 🎯 Objetivos

✅ Mostrar dominio en tecnologías **HTML, CSS, JavaScript, .NET**  
✅ Aplicar conocimientos en **FHIR, RESTful APIs y estructura de datos clínicas**  
✅ Diseñar una **UX/UI profesional**, con soporte para **modo claro/oscuro**  
✅ Simular llamadas a **CCL/SQL** como parte del backend sanitario  
✅ Integrar todas las piezas como lo exige un entorno real de hospital

---

## 🛠️ Tecnologías utilizadas

| Tecnología        | Uso                                                                 |
|-------------------|----------------------------------------------------------------------|
| HTML, CSS, JS      | Frontend (estructura, estilo, interactividad)                       |
| ASP.NET Core       | Backend RESTful para servir datos y simular entorno hospitalario    |
| FHIR (HAPI Server) | Estandar clínico para acceso a pacientes (http://hapi.fhir.org)      |
| CCL/SQL Simulado   | Representación básica de consultas de resultados de laboratorio      |
| UX/UI              | Diseño moderno, responsive, accesible, con modo oscuro integrado     |

---

## 🚀 Instrucciones para ejecutar el proyecto

### ✅ Requisitos

- [.NET 6 SDK o superior](https://dotnet.microsoft.com/download)
- Visual Studio 2022 o Visual Studio Code
- Navegador web (Chrome, Edge, Firefox)

### 📦 Pasos

1. Clonar el proyecto o copiar los archivos en una carpeta:
   ```bash
   git clone https://github.com/CesarDavidMorenR/CernerMpageDemo.git
   cd CernerMpageDemo
   ```

2. Restaurar dependencias:
   ```bash
   dotnet restore
   ```

3. Ejecutar el proyecto:
   ```bash
   dotnet run
   ```

4. Acceder al frontend:
   Abre tu navegador en:
   ```
   http://localhost:5259
   ```

---

## 📂 Estructura del proyecto

```
CernerMpageDemo/
│
├── Controllers/
│   └── PatientsController.cs       # Expone endpoints API para pacientes y lab results
│
├── Services/
│   ├── FhirService.cs              # Conexión a servidor FHIR para obtener pacientes
│   └── CclService.cs               # Simula resultados de laboratorio (tipo CCL/SQL)
│
├── Models/
│   ├── PatientModel.cs             # Modelo de paciente simplificado
│   └── LabResult.cs                # Modelo para resultados clínicos
│
├── wwwroot/
│   ├── index.html                  # Interfaz MPage
│   ├── styles.css                  # Estilos visuales + modo oscuro elegante
│   └── app.js                      # Funcionalidad JS (fetch API, toggle dark mode)
│
├── Program.cs                      # Configuración de la app .NET
├── appsettings.json                # Configuración opcional
└── README.md                       # Este documento
```

---

## 🧠 ¿Qué se demuestra con este proyecto?

- Capacidad de construir **endpoints RESTful** con .NET
- Uso de datos reales desde una API FHIR (modelo interoperable clínico)
- Entendimiento de la **estructura de recursos FHIR** (Patient, Bundle)
- Buenas prácticas de **separación de capas** (Controller, Service, Model)
- Dominio de **consultas básicas simuladas SQL/CCL**
- Diseño centrado en el usuario con **accesibilidad y UI limpia**
- Flujo de trabajo técnico similar al de una **MPage real en Cerner Millennium**

---

## 📷 Vista previa

- **Modo claro**:
  ![image](https://github.com/user-attachments/assets/f2a25c9f-4d9d-445e-b93f-cc64154f4772)


- **Modo oscuro**:
  ![image](https://github.com/user-attachments/assets/c71020d7-c870-42fd-9979-ce06da663f6b)


---

## ✅ Consideraciones finales

Este proyecto está diseñado para un contexto de **entrevista técnica**. No es una app clínica en producción, pero sigue los estándares y flujos que se encontrarían en un entorno real como el **HUCA** o cualquier otro hospital que use **Cerner Millennium**.

### ✅ Demuestra:

- Estructura y organización de código profesional
- Comprensión del entorno sanitario y clínico
- Capacidad de integrar múltiples tecnologías en tiempo récord
- Motivación y aprendizaje rápido

---

## 📬 Contacto

Cesar Moreno Ramirez  
Desarrollador Full Stack motivado para contribuir al sector salud con soluciones eficientes, accesibles y modernas.  
✉️ cesardavidmor@gmail.com | 📍 Asturias, España
