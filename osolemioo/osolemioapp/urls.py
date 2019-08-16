from django.urls import path
from .views import mivista
urlpatterns = [
    path('bien/',mivista),
]