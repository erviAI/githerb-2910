from pydantic import BaseModel
from typing import List
from models.herb import Herb


class BasketOfHerbs(BaseModel):
    id: int
    herbs: List[Herb] = []

    def is_ready_to_send(self):
        # more than 0, less than 10 but not 7. Should throw exceptions if they do not meet the criteria
        if len(self.herbs) == 0:
            return False
        elif len(self.herbs) == 7:
            raise Exception("Basket cannot have 7 Herbs")
        elif len(self.herbs) >= 10:
            raise Exception("Basket cannot have more than 10 herbs")
        else:
            return True
