# Exceptional Orders Management System

A lightweight full-stack exercise for managing and processing exceptional business orders.

## 🚀 Overview
This system allows managers to review orders flagged as "Exceptional". The workflow focuses on filtering pending high-priority items and processing them via a state-machine logic (Approve/Reject).

## 🛠 Tech Stack
- **Backend:** .NET 8 Web API (REST)
- **Frontend:** Angular 18 (Standalone Components, Signals)
- **Communication:** JSON (Enum-to-String serialization)

## 🏗 Project Structure
```text
├── backend/            # ASP.NET Core Web API
│   ├── Controllers/    # REST Endpoints
│   ├── Models/         # Domain Models & Enums
│   └── Repositories/   # In-memory Data Store (Thread-safe)
└── frontend/           # Angular Standalone Application
    ├── src/app/
    │   ├── models/     # TypeScript Interfaces & Enums
    │   ├── services/   # HttpClient & State Management (Signals)
    │   └── components/ # UI Implementation