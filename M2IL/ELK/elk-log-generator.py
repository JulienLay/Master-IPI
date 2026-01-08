import random
import time
from datetime import datetime

# Liste de 10 adresses IP publiques réparties dans le monde
public_ips = [
    "8.8.8.8",       # USA (Google DNS)
    "1.1.1.1",       # Australie (Cloudflare)
    "208.67.222.222",# USA (OpenDNS)
    "203.0.113.1",   # Japon (exemple)
    "185.107.56.231",# Allemagne
    "91.121.79.77",  # France
    "190.93.247.1",  # Brésil
    "37.9.1.1",      # Russie
    "196.25.1.1",    # Afrique du Sud
    "202.108.22.5"   # Chine
]

# Niveaux de log possibles
log_levels = ["INFO", "DEBUG", "WARNING", "ERROR", "CRITICAL"]

# App et classe fictives
app_name = "LogApp"
# Classes de l'application : Services, Repositories, Controllers

class_names = [
    # Controllers (10)
    "UserController",
    "ProductController",
    "OrderController",
    "AuthController",
    "SearchController",
    "PaymentController",
    "AdminController",
    "SessionController",
    "DashboardController",
    "ShippingController"

    # Services (10)
    "AuthService",
    "PaymentService",
    "UserService",
    "EmailService",
    "NotificationService",
    "InventoryService",
    "ShippingService",
    "AnalyticsService",
    "BillingService",
    "SearchService",

    # Repositories (10)
    "UserRepository",
    "ProductRepository",
    "OrderRepository",
    "InvoiceRepository",
    "SessionRepository",
    "CartRepository",
    "LogRepository",
    "TokenRepository",
    "PaymentRepository",
    "NotificationRepository",
]


# Messages fictifs
messages = [
    "User login successful",
    "Payment processed",
    "Email sent to user",
    "Notification pushed",
    "User data updated",
    "API request received",
    "Token expired",
    "Database connection established",
    "File not found",
    "Unhandled exception occurred",
    "Cache cleared",
    "New user registered",
    "Product added to cart",
    "Order confirmed",
    "Email verification sent",
    "Database timeout",
    "External API unreachable",
    "Session expired",
    "Invalid user credentials",
    "Access token generated",
    "Permission denied",
    "New order received",
    "Stock updated",
    "PDF invoice generated",
    "User profile picture uploaded",
    "Webhook received",
    "Background job started",
    "Background job completed",
    "Item removed from cart",
    "Duplicate request detected",
    "Rate limit exceeded",
    "User logged out",
    "Payment gateway error",
    "Coupon code applied",
    "Data synced with third-party API",
    "2FA code sent",
    "New comment added",
    "Push notification failed",
    "Settings updated",
    "Email bounce detected"
]


# Fichier de log
log_file = "app_logs.txt"

def generate_log():
    timestamp = datetime.now().isoformat()
    level = random.choice(log_levels)
    classname = random.choice(class_names)
    publicip = random.choice(public_ips)
    message = random.choice(messages)

    log_line = f"{timestamp} - {level} - {app_name} - {classname} - {publicip} - {message}"
    return log_line

def write_logs():
    with open(log_file, "a") as file:
        while True:
            log_entry = generate_log()
            file.write(log_entry + "\n")
            time.sleep(0.2)

if __name__ == "__main__":
    print("Démarrage de l'application de log. Appuyez sur Ctrl+C pour arrêter.")
    try:
        write_logs()
    except KeyboardInterrupt:
        print("\nArrêt de l'application.")
