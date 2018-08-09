class Plant:

    def __init__(self, color, absorption, min_water):
        self.color = color
        self.water_amount = 0
        self.needs_water = True
        self.absorption = absorption
        self.min_water = min_water

    def __repr__(self):
        if self.needs_water:
            return 'The ' + self.color + ' ' + str(self.__class__.__name__) + ' needs water'
        else:
            return 'The ' + self.color + ' ' + str(self.__class__.__name__) + ' is fine'

    def water(self, amount):
        self.water_amount += amount * self.absorption
        self.needs_water = self.water_amount < self.min_water


class Flower(Plant):

    def __init__(self, color):
        super().__init__(color, 0.75, 5)


class Tree(Plant):

    def __init__(self, color):
        super().__init__(color, 0.4, 10)

