from pydantic import BaseModel

class Herb(BaseModel):
    id: int
    name: str