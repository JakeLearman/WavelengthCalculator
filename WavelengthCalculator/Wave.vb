Public Class wave
    'declaring variable Number1 and Answer as single values
    Private Number1 As Single
    Private Answer As Single
    'declaring frequency as a property of the class wave, where Number1 encapsulates the value
    Public Property Frequency() As Single
        Get
            Return Number1
        End Get
        Set(value As Single)
            Number1 = value
        End Set
    End Property
    'declaring CalcAnswer as a property of the class wave, where Answer is processed
    Public Property CalcAnswer() As Single
        Get
            Return Answer
        End Get
        Set(value As Single)
            Answer = value
        End Set
    End Property
    'Declaring the function Result in which the wavelength is calculated.
    Public Function Result(ByVal Number1 As Single) As Single
        'The inputted value Number1 divides the speed of light to give the wavelength
        Answer = 300000000 / Number1
        'The wavelength is returned as the output of the function
        Return Answer
    End Function
End Class