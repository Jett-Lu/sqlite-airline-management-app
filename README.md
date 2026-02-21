# \# SQLite Airline Management App  

# \### Desktop Reservation System Built with C#, Windows Forms, and SQLite

# 

# \## System Architecture

# 

# +-------------------------------------------------------+

# |                   Windows Forms UI                    |

# |                                                       |

# |  mainFrm  →  bookingFrm  →  receiptFrm               |

# |                                                       |

# +----------------------------↓--------------------------+

# &nbsp;                            |

# &nbsp;                            v

# +-------------------------------------------------------+

# |                Application Logic Layer                |

# |  - Booking validation                                 |

# |  - Seat allocation logic                              |

# |  - Workflow coordination                              |

# +----------------------------↓--------------------------+

# &nbsp;                            |

# &nbsp;                            v

# +-------------------------------------------------------+

# |              Data Access Layer (EF 6 ORM)             |

# |  - DbContext                                          |

# |  - Entity Models                                      |

# |  - CRUD Operations                                    |

# +----------------------------↓--------------------------+

# &nbsp;                            |

# &nbsp;                            v

# +-------------------------------------------------------+

# |                SQLite Embedded Database               |

# |  AirlineReservationSystem.db                          |

# +-------------------------------------------------------+

# 

# \## Overview

# 

# SQLite Airline Management App is a transactional desktop reservation system developed in C# using Windows Forms and SQLite. The application leverages Entity Framework as an ORM to manage relational data access and persistence.

# 

# The system models a simplified airline booking workflow, enabling users to create reservations, manage seat allocations, and generate booking confirmations through a structured multi-form interface.

# 

# This project demonstrates applied software engineering principles in a stateful desktop environment with persistent data storage.

# 

# \## Core Capabilities

# 

# \- Reservation creation and seat allocation

# \- Persistent booking storage using SQLite

# \- Entity Framework-based data abstraction

# \- Structured multi-form navigation workflow

# \- Receipt generation and booking confirmation

# \- Local embedded database for standalone execution

# 

# \## Architecture Overview

# 

# The application follows a layered design approach:

# 

# \### 1. Presentation Layer

# Windows Forms-based UI handling user interaction and navigation.

# 

# \### 2. Application Logic Layer

# Implements:

# \- Booking workflow coordination

# \- Input validation

# \- Seat availability handling

# \- Reservation confirmation logic

# 

# \### 3. Data Access Layer

# Entity Framework manages:

# \- Database context lifecycle

# \- Entity modeling

# \- Query execution

# \- CRUD operations

# 

# \### 4. Persistence Layer

# SQLite provides:

# \- Lightweight embedded relational storage

# \- Portable database file

# \- Zero external server dependencies

# 

# \## Technology Stack

# 

# \- C#

# \- .NET Framework

# \- Windows Forms

# \- SQLite

# \- Entity Framework 6

# \- Visual Studio

# 

# \## Design Considerations

# 

# \- \*\*Embedded database\*\* selected to eliminate external infrastructure requirements.

# \- \*\*ORM abstraction\*\* used to reduce manual SQL management and improve maintainability.

# \- \*\*Multi-form separation\*\* implemented to isolate concerns between navigation, booking, and confirmation logic.

# \- \*\*Local persistence\*\* ensures application portability across development environments.

# 

# \## How to Run

# 

# \### Requirements

# 

# \- Visual Studio

# \- .NET Framework 4.x

# \- NuGet package restore enabled

# 

# \### Setup

# 

# 1\. Clone the repository.

# 2\. Open `sqlite-airline-management-app.sln` in Visual Studio.

# 3\. Restore NuGet packages.

# 4\. Build the solution.

# 5\. Run the application.

# 

# \## Engineering Concepts Demonstrated

# 

# \- Desktop application architecture

# \- Layered design separation

# \- ORM-based relational data access

# \- State-driven workflow management

# \- Persistent transactional data handling

# \- Configuration management via App.config

# 

# \## Purpose

# 

# This project demonstrates implementation of a structured, stateful desktop reservation system with embedded database persistence. It reflects practical application of GUI design, data modeling, and workflow orchestration within a managed .NET environment.



# \## Notes

# 

# \- Build artifacts (`bin/`, `obj/`, `.vs/`) are excluded.

# \- SQLite database file included for demonstration purposes.

