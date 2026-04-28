[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/NYYg_5y-)

# ASP.NET MVC Assignments — PD2

This repository contains the daily assignments and tasks for the ASP.NET MVC course.

---

## 🎥 Recorded Sessions

All recorded video sessions are available here:

📁 [Google Drive — Recorded Videos](https://drive.google.com/drive/folders/1b38tYzGRNEhG_P-zDGmJOqEh85WBj6RN?usp=sharing)

---

## 📁 Repository Structure

| Folder | Description |
|--------|-------------|
| Day1 – Day7 | Daily demos and assignments |
| Day8 | CRUD with EF Core, Repositories, Tag Helpers, Bundling & Validation |
| Day9 | Identity, Attribute Routing, Route Constraints, External Logins |
| Records | Additional resources |

---

## Day 8 — Assignment

### Task 1: Trainees, Tracks & Courses App (ASP.NET Core MVC)

- Full CRUD operations for Trainees, Tracks, and Courses
- EF Core Code First → `TraineesDB`
- Repository pattern with custom service injection
- Tag Helpers: `<environment>`, `<partial>`
- Styling with Bootstrap and Bundling
- Client-side validation

**Models:**

- `Track`: ID, Name, Description, IEnumerable\<Trainee\>?
- `Trainee`: ID, Name, Gender, Email, MobileNo, Birthdate, TrackID, Track
- `Course`: ID, Topic, Grade
- `TraineeCourse`: TraineeID, CourseID, Grade, Trainee?, Course?

Relationships: Track → Trainee (1:M) | Trainee ↔ Course (M:M)

---

### Task 2: Products & Customers App

- Full CRUD for Products and Customers
- Product details displayed as Bootstrap Cards in Index, Details, Delete views
- `_CardPartial` partial view to reduce repetition
- `Product_Cust_ViewModel` used in Customer Details action

**Models:**

- `Product`: ID, Name, Image, Price, Description, CustID, Customer
- `Customer`: ID, Name, Gender, Email, PhoneNum, IEnumerable\<Product\>?

Relationship: Customer → Product (1:M)

---

## Day 9 — Assignment

### Task 1: Continue Day 8 (Track-Trainee-Course) + Identity

- ASP.NET Core Identity: Register, Login, Logout
- Extended `IdentityUser` with `Client` class: FirstName, LastName, Nationality, EducationLevel
- Attribute Routing & RoutePrefix on Track controller
- Route Constraints on actions

### Task 2: External Logins App

- Individual User Authentication Template
- Google as external login provider
- Additional provider (Microsoft, Facebook, Twitter, etc.)

---

## 📋 Final Project Details

Choose one of the following ASP.NET Core MVC web applications to implement:

- Purchase Online System (Amazon / Souq / Jumia / Noon)
- Order-Food Online System (Talabat / elmenus)
- Ticket-Booking Online System (Skyscanner / Wego)
- Doctor Appointments Reservation System (Vezeeta)
- Online-Courses Platform (Coursera / Udemy / Pluralsight)

**Requirements:**
- Apply all course concepts (DI, Repository, DataAnnotations, Validation, Identity, External Logins)
- Download and apply a suitable template for the layout
- Optional extras: online payment (Stripe/PayPal), Google Maps

**Deadline:** 15 May | Groups of 5–6 members (SWA separated from PD)
