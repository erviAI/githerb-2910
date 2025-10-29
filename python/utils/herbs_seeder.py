import json
from models.herb import Herb
from utils.in_memory_datastore import herbs_data_store

# Seeder JSON string
herbs_json = """
            [
                { "id": 1, "name": "Basil" },
                { "id": 2, "name": "Rosemary" },
                { "id": 3, "name": "Thyme" },
                { "id": 4, "name": "Sage" },
                { "id": 5, "name": "Mint" },
                { "id": 6, "name": "Parsley" },
                { "id": 7, "name": "Cilantro" },
                { "id": 8, "name": "Dill" },
                { "id": 9, "name": "Oregano" },
                { "id": 10, "name": "Chives" }
            ]
            """

def seed_herbs():
    # Parse the JSON string
    herbs = json.loads(herbs_json)
    # Clear existing data
    herbs_data_store.clear()
    # Populate the data store
    for herb in herbs:
        herbs_data_store.append(Herb(**herb))