import React, { useEffect, useRef, useState } from 'react';
import style from './Tareas.module.css'
import { Select, Space } from 'antd';
import { PlusOutlined } from '@ant-design/icons';
import { Divider, Input, Button } from 'antd';
let index = 0;

// IMPUT VARIADO*********************************************
const handleChange = (value) => {
  console.log(`selected ${value}`);
};
const options = [
  {
    label: 'China',
    value: 'china',
    emoji: '🇨🇳',
    desc: 'China (中国)',
  },
  {
    label: 'USA',
    value: 'usa',
    emoji: '🇺🇸',
    desc: 'USA (美国)',
  },
  {
    label: 'Japan',
    value: 'japan',
    emoji: '🇯🇵',
    desc: 'Japan (日本)',
  },
  {
    label: 'Korea',
    value: 'korea',
    emoji: '🇰🇷',
    desc: 'Korea (韩国)',
  },
];
// IMPUT VARIADO*********************************************
const Tareas = () => {

    // IMPUT NORMAL*********************************************

    const [items, setItems] = useState(['jack', 'lucy']);
    const [name, setName] = useState('');
    const inputRef = useRef(null);
    
    const onNameChange = (event) => {
      setName(event.target.value);
      alert("aqui ***"+event.target.value )
    };


    const addItem = (e) => {
      e.preventDefault();
      setItems([...items, name || `New item ${index++}`]);
      setName('');
      setTimeout(() => {
        inputRef.current?.focus();
      }, 0);
    };
    // IMPUT NORMAL*********************************************


    const [tareas, setTareas] = useState([])
    const [tareas2, setTareas2] = useState([])

    const mostrarTareas = async () => {

        const response = await fetch("api/tarea/Lista").then(response => response.json())
            .then(data => { console.log(JSON.stringify(data, null, 2)); setTareas(data); })
            
            .catch(error => console.error('Error:', error));
    }
    const mostrarTareas2 = async () => {

        const response = await fetch("api/tarea2/Lista").then(response => response.json())
            .then(data => { console.log(JSON.stringify(data, null, 2)); setTareas2(data); })

            .catch(error => console.error('Error:', error));
    }

    useEffect(() => {

        mostrarTareas();
        mostrarTareas2();

    }, [])

    console.log("Tareas2:", tareas2);

    function alerta() {
        alert("Usted presion� este bot�n")
    }
    function dilbani(e){
        e.preventDefault();

        alert("Usted dilbani"+ selectedValue)
    }
    const [selectedValue, setSelectedValue] = useState(null);
    
    const onNameChange2 = (selectedOption) => {
        // Actualiza el estado con el nuevo valor seleccionado
        setSelectedValue(selectedOption);
    alert(selectedOption)
        // Paso 3: Muestra un alert con el valor actualizado
        //alert(`Valor seleccionado: ${selectedOption ? selectedOption.value : 'Ninguno'}`);
      };
      

    return (
        <>

            <Select
                style={{
                    width: 300,
                }}
                placeholder="custom dropdown render"
                onChange={onNameChange2}
                options={tareas.map((item) => ({
                    label: item.nombreGenero,
                    value: item.id,
                }))}
                value={selectedValue}
            />
            <Select
                style={{
                    width: 300,
                }}
                placeholder="escoge tu formato"
                //onChange={onNameChange2}
                options={tareas2.map((item) => ({
                    label: item.nombreFormato,
                    value: item.id,
                }))}
                //value={selectedValue}
            />



            <Select
                mode="multiple"
                style={{
                width: '100%',
                }}
                placeholder="select one country"
                defaultValue={['china']}
                onChange={handleChange}
                optionLabelProp="label"
                options={options}
                optionRender={(option) => (
                <Space>
                    <span role="img" aria-label={option.data.label}>
                    {option.data.emoji}
                    </span>
                    {option.data.desc}
                </Space>
                )}
            />

            <div className="list-group" >
                <h2 className="text-white" > Lista de Generos </h2>

                {
                    tareas.map(
                        (item) => (

                            <>


                                <div className="container bg-dark p-4 vh-10" >



                                    <div className="row" >

                                        <div className="col-sm-12" >

                                        </div>

                                    </div>

                                    <div className="row mt-4" >

                                        <div className="col-sm-12" >

                                            <div className="List-group-item list-group-item-action" >
                                                <h5 className="text-primary" > {item.nombreGenero} </h5>

                                                <div className="d-flex justify-content-between">
                                                    <button
                                                        className="btn btn-sm btn-outline-primary"
                                                        onClick={alerta}
                                                    >
                                                        Ver
                                                    </button>
                                                </div>
                                            </div>

                                        </div>

                                    </div>



                                </div>


                            </>

                        )

                    )
                }

            </div>   


            <Button 
                type="primary"
                onClick={dilbani}
                >
                Guardar
            </Button>

        </>
    );
}

export default Tareas;
