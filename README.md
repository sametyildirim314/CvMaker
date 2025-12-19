# CvMaker


Project Overview
This project is a personal CV/Portfolio web application. It is a single page website developed using ASP.NET Web Forms technology.
Technical Specifications
Platform: ASP.NET Web Forms
Programming Language: C#
Frontend: HTML5, CSS3, Bootstrap
Design: Responsive (Mobile Compatible)
Template Source: W3layouts
Project Structure
1. Main Sections
The project consists of the following main sections:
a. Sidebar
Profile photo
Name and title information
Navigation menu
b. Main Content Sections
Home
Welcome message
Brief information about (Dynamic content with Repeater1 control)
About
Educational information (Dynamic content with Repeater2 control)
Services
Technical skills and abilities (Dynamic content with Repeater4 control)
Visual richness with Font Awesome icons
Experiences (News)
Work experiences (Dynamic content with Repeater3 control)
Contact
Contact form
Name, Email, Subject and Message fields
Send and Cancel buttons
2. Technical Details
Data Binding
Displaying dynamic content from database using Repeater controls
4 different Repeater controls:
Repeater1: General information
Repeater2: Education information
Repeater3: Work experiences
Repeater4: Skills
Form Control
ASP.NET Web Forms controls (TextBox, Button)
AJAX support for ScriptManager
Server-side form processing
Design Features
Bootstrap grid system
Responsive design
Custom CSS (style.css)
Font Awesome icons
Google Fonts integration (Lato font family)
3. Security Features
Form validation
Cross-site scripting (XSS) protection
ViewState protection
Installation Requirements
Visual Studio (2017 or later)
.NET Framework 4.5 or later
SQL Server (for database)
IIS Express or IIS
Recommendations for Development
Configuring database connection settings in Web.config file
Implementing data processing logic in Code-behind file (Default.aspx.cs)
Controlling data binding operations of repeater controls
Making email service integration for contact form
Customization Opportunities
Changing color scheme (via style.css)
Adding new sections
Editing existing sections
Different adding language support
Admin panel integration
This CV Maker project provides a basic infrastructure to create a professional CV/Portfolio website. It is easily expandable and customizable thanks to its modular structure.
