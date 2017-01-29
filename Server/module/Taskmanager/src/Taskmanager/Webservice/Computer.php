<?php

namespace Taskmanager\Webservice;

use Application\Model\Adapter;
use \Taskmanager\Model;
use \Zend\Db\Adapter\Driver\Mysqli\Mysqli;
use \Zend\Db\Sql\Expression;
use \Zend\Db\Sql\Platform\Mysql\Mysql;
use \Zend\Db\Sql\Select;

class Computer
{
    /**
     *
     * Dodaje informacje o jednym konkretnym komputerze.
     * Parametrem wskazanego komputera powinien być string, jako zakodowany jso, składający się z następujących pól
     * id : "726d1326-8333-4715-898c-940a4c8a799b" string,
     * computer_name : "MAC" string,
     * user_name : "Marek" string,
     * cpu : 17 int [%],
     * ram_mb_used : 25 int [%],
     * hdd_mb_free : 100268 int[] (string odzielony znakiem średnika)
     * processes : "chrome" string[] (string oddzielony znakiem średnika)
     * create: date
     * @param  string $data
     * @return bool
     */
    public function addInformation($data)
    {
        try {
            $data = json_decode($data, true);
            $row = new Model\TaskmanagerRow();
            $row->id = $data['id'];
            $row->cpu = $data['cpu'];
            $row->computer_name = $data['computer_name'];
            $row->user_name = $data['user_name'];
            $row->ram_mb_used = $data['ram_mb_used'];
            $row->hdd_mb_free = json_encode($data['hdd_mb_free']);
            $row->processes_count = count(explode(';', $data['processes']));
            $row->processes = json_encode($data['processes']);
            $row->save();

            return true;


        } catch (\Exception $e) {

            return false;
        }


    }

    /**
     * Pobiera informacje o jednym wskazanym komputerze, parametrem jest string json, informacje zwrotne również zawarte są w json jako string, należy wynik zdekodować.
     * Przykładowe parametr ID: f44dccef-01ae-4bcb-bb51-5bcb29ed534f - jest to wartość ID metody getList()
     * Metoda zwraca następujące informacje:
     * - create: date - data utworzenia wpisu
     * - id: string - id komputera
     * - computer_name: string - nazwa komputera
     * - cpu: int - procentowe użycie procesora
     * - ram_mb_used: int - procentowe użycie pamięci RAM
     * - hdd_mb_free: int procentowe zużycie przestrzeni dysku twardego
     * - processes: string - nazwy procesów oddzielone znakiem średnika;
     * - id_computer: id - id informacji o komputerze.
     *
     * @param string $id
     * @return string
     */
    public function getInformation($id)
    {
        try {
            $table = new Model\TaskmanagerTable();
            $select = $table->getSql()->select();
            $select->columns([
                'create',
                'id',
                'computer_name',
                'user_name',
                'cpu',
                'processes',
                'ram_mb_used',
                'hdd_mb_free',
                'id_computer'
            ]);
            $select->where(['id' => $id]);
            $rows = $table->selectWith($select);
            $data = $rows->toArray();
            return json_encode($data);


        } catch (\Exception $e) {
            throw new \SoapFault("500", "Błąd odczytu danych");

        }
    }

    /**
     *  Pobiera listę wszystkich komputerów jako string json
     *  Kolumny do zwrotu:
     *  - id: sting - Identyfikator komputera
     *  - computer_name: string -  nazwa komputer
     *  - cpu_avg: int - średnia wartość zasobów  procesora
     *  - ram_avg: int - średnia wartość zabieranych zasobów pamieci ram
     *  - process_avg: int - średnia ilośc procesów uruchomianych
     *  -  id_computer: int - ilość wierszy danych
     *
     * @return string
     */
    public function getList()
    {
        try {

            $table = new Model\TaskmanagerTable();
            $rows = $table->select(function (Select $select) {
                $select->columns([
                    'id',
                    'computer_name',
                    'cpu_avg' => new Expression('AVG(cpu)'),
                    'ram_avg' => new Expression('AVG(ram_mb_used)'),
                    'process_avg' => new Expression('AVG(processes_count)'),
                    'id_computer' => new Expression('COUNT(id_computer)'),
                ]);
                $select->group(['id', 'computer_name']);
            });
            $data = $rows->toArray();
            return json_encode($data);


        } catch (\Exception $e) {
            throw new \SoapFault("500", "Błąd odczytu danych");
        }

    }


}